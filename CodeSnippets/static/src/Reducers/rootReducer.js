import { combineReducers } from 'redux';
import userReducer from './userReducer.js';
import globalReducer from './globalReducer.js';

export default combineReducers( {
    global : globalReducer,
    user: userReducer
});