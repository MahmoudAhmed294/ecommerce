import React, { useEffect } from 'react';
import { useRouter } from 'next/router';

import { useLoginMutation } from 'shared/src/api/authApi';
import { useLogout, useUser } from 'shared/src/hooks';

type Props = {};

const login = (props: Props) => {
  const [login, { isLoading, data, status }] = useLoginMutation();
  const { isLoggedIn, user } = useUser();
  const router = useRouter();

  useEffect(() => {
    if (isLoggedIn) {
      router.push('/');
      console.log(user);
    }
  }, [isLoggedIn]);

  return (
    <button
      onClick={() => login({ email: 'john@mail.com', password: 'changeme' })}
    >
      Login
    </button>
  );
};

export default login;
