import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import * as serviceWorker from './serviceWorker';
import 'fomantic-ui/dist/semantic.min.css';
import 'toastr/build/toastr.min.css'

import { Provider } from 'react-redux';

import configureStore from './Store/configureStore.js';

const store = configureStore();

ReactDOM.render(<Provider store={store}>
        <App />
    </Provider>, 
    document.getElementById('root'));
    

serviceWorker.unregister();
