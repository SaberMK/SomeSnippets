import { AUTH_USER } from '../Actions/userActions.js'

const initState = {
    auth : {
        login : '',
        password : '',
    },
    register : {
        login : '',
        password: '',
        passwordConfirmation: ''
    }
}

const userReducer = (state = initState, action) => {
    switch (action.type) {
        case AUTH_USER: 
            return { ...state, auth : action.payload }
        default:
            return state;
    }
}

export default userReducer;