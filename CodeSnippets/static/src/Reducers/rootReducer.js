import { combineReducers } from 'redux';
import { reducer as formReducer } from 'redux-form';
import globalReducer from './globalReducer.js';

export default combineReducers( {
    global : globalReducer,
    form: formReducer
});