import axios from 'axios';


export const AUTH_USER = 'AUTH_USER';


export function authUser (login, password) {
    return {
        type : AUTH_USER,
        payload: {
            login,
            password
        }
    }
}