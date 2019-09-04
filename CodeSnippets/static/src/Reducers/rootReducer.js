import { combineReducers } from 'redux';
import { reducer as formReducer } from 'redux-form';

import globalReducer from './globalReducer.js';
import languagesReducer from './languagesReducer.js';
//import addSnippetReducer from './addSnippetReducer.js';

export default combineReducers( {
    global : globalReducer,
    languages : languagesReducer,


    form: formReducer
});