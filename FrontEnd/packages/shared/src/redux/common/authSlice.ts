import { PayloadAction, createSlice } from '@reduxjs/toolkit';
import Cookies, { CookieAttributes } from 'js-cookie';
import { IUser, IAuthState } from '../../model';

const expirationDate = new Date().getMinutes();

const tokenSetting: CookieAttributes = {
  secure: true,
  expires: expirationDate,
  sameSite: 'Lax',
};
Object.freeze(tokenSetting);

const initialState: IAuthState = {
  isLoggedIn: false,
  user: null,
  role: 'REGULAR',
};

const authSlice = createSlice({
  name: 'auth',
  initialState,
  reducers: {
    login: (state, action: PayloadAction<IUser>) => {
      Cookies.set('access_token', action.payload.access_token, tokenSetting);
      Cookies.set('refresh_token', action.payload.refresh_token, tokenSetting);
      state.isLoggedIn = true;
      state.user = action.payload;
    },
    logout: (state) => {
      Cookies.remove('access_token');
      Cookies.remove('refresh_token');
      state.isLoggedIn = false;
      state.user = null;
    },
  },
});

export const { login, logout } = authSlice.actions;

export default authSlice.reducer;
