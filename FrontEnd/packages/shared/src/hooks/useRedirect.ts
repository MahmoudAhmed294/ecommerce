import { useRouter } from 'next/router';
import { useEffect } from 'react';
import { useSelector } from 'react-redux';

export const useRedirect = (redirectTo = '/login') => {
  const history = useRouter();
  const isLoggedIn = useSelector((state: any) => state.auth.isLoggedIn);

  useEffect(() => {
    if (!isLoggedIn && typeof window !== undefined) {
      history.push(redirectTo);
    }
  }, []);

  return isLoggedIn;
};
