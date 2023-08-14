import { useAppSelector } from "../redux";

export const useUser = () => {
  const { isLoggedIn, user } = useAppSelector((state) => state.auth);

  return {
    isLoggedIn,
    user,
  };
};
