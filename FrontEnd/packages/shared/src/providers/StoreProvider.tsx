import React from 'react';
import { Provider } from 'react-redux';
import { Store } from '@reduxjs/toolkit';

type Props = {
  children: React.ReactElement;
  store:Store
};

const StoreProvider = ({ children, store }: Props) => (
  <Provider store={store}>{children}</Provider>
);

export default StoreProvider;
