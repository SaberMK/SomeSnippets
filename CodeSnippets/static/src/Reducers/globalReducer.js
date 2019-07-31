import { AUTH_USER, authUser } from "../Actions/globalActions.js";

const initState = {
    token : '',
    username : '',
}

const globalReducer = (state = initState, action) => {
    switch (action.type) {
        case AUTH_USER: {
            return {...state, 
                ...action.payload
            }
        }
        default:
            return state;
    }
}

export default globalReducer;