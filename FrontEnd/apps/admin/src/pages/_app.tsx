import React from 'react';
import { AppProps } from 'next/app';
import { Provider, store } from 'shared/src/redux';

const MyApp = ({ Component, pageProps }: AppProps) => {
  return (
    <Provider store={store}>
      {/*@ts-ignore */}
      <Component {...pageProps} />
    </Provider>
  );
};

export default MyApp;

// export function getServerSideProps() {
//   allowReducers('REGULAR');
// }
