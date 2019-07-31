export const AUTH_USER = 'AUTH_USER';

export const authUser = (token, username) => {
    return {
        action : AUTH_USER,
        payload : {
            token,
            username
        }
    }
}