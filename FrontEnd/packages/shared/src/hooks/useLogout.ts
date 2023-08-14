import { useRouter } from 'next/router';
import { useDispatch } from 'react-redux';
import { logout } from '../redux/common/authSlice';

export const useLogout = () => {
  const history = useRouter();
  const dispatch = useDispatch();

  const handleLogout = () => {
    dispatch(logout());
    history.push('/login');
  };

  return handleLogout;
};
