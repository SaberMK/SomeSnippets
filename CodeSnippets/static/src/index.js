import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import * as serviceWorker from './serviceWorker';
import 'fomantic-ui/dist/semantic.min.css';

import { createStore } from 'redux';
import { Provider } from 'react-redux';
import rootReducer from "./Reducers/rootReducer.js";

const store = createStore(rootReducer);

/*
ReactDOM.render(<Provider store={store}>
        <App />
    </Provider>, 
    document.getElementById('root'));
    */

serviceWorker.unregister();
