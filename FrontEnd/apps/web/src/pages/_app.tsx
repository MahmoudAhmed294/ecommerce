import React from 'react';

import { AppProps } from 'next/app';
import 'ui/styles.css';

const MyApp = ({ Component, pageProps }: AppProps) => (
  // eslint-disable-next-line react/jsx-props-no-spreading
  <Component {...pageProps} />
);

export default MyApp;
