export interface ILoginInput {
  email: string;
  password: string;
}

export interface ILoginOutput {
  access_token: string;
  refresh_token: string;
}
export interface IUser extends Omit<ILoginInput, 'password'>, ILoginOutput {}

export type IUserRole = "ADMIN" | "REGULAR";

export interface IAuthState {
  isLoggedIn: boolean;
  user: IUser | null;
  role: IUserRole;
}
