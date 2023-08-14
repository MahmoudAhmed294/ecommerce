// api/authApi.ts
import { baseApi } from '.';
import { ILoginInput, ILoginOutput, IUser } from '../model';
import { login } from '../redux/common/authSlice';

export const authApi = baseApi.injectEndpoints({
  endpoints: (builder) => ({
    login: builder.mutation<ILoginOutput, ILoginInput>({
      query: (credentials) => ({
        url: 'auth/login',
        method: 'POST',
        body: credentials,
      }),
      async onQueryStarted(args, { dispatch, queryFulfilled }) {
        const result = await queryFulfilled;
        dispatch(login(result.data as IUser));

      },
    }),
    register: builder.mutation<
      { token: string },
      { email: string; password: string }
    >({
      query: (credentials) => ({
        url: '/auth/login',
        method: 'POST',
        body: credentials,
      }),
      //   async onQueryStarted(args, { dispatch, queryFulfilled }) {
      //     const result = await queryFulfilled;
      //     // dispatch(setToken(result.data.token));
      //     return result;
      //   },
      //   async onQueryRejected(error, { dispatch }) {
      //     // dispatch(setToken(null));
      //     throw error;
      //   },
    }),
  }),
});

export const { useLoginMutation, useRegisterMutation } = authApi;
