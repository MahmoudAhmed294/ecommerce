import React, { useEffect } from 'react';
import { useUser, useLogout, useRedirect } from 'shared/src/hooks';

const Page = () => {
  useRedirect();
  const { isLoggedIn, user } = useUser();
  const logout = useLogout();

  return (
    <div>
      <button onClick={() => logout()}>logout</button>
    </div>
  );
};

export default Page;
