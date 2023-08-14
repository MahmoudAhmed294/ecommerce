import { useState, useEffect } from 'react';

export const useLocalStorage = (
  key: string,
  defaultValue: any
): [any, React.Dispatch<React.SetStateAction<any>>, () => void] => {
  const [value, setValue] = useState(() => {
    try {
      const item = window.localStorage.getItem(key);
      return item ? JSON.parse(item) : defaultValue;
    } catch (error) {
      console.log(error);
      return defaultValue;
    }
  });

  useEffect(() => {
    try {
      window.localStorage.setItem(key, JSON.stringify(value));
    } catch (error) {
      console.log(error);
    }
  }, [key, value]);

  const remove = () => {
    window.localStorage.removeItem(key);
  };

  return [value, setValue, remove];
};
