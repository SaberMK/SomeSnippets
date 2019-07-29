import { createStore } from 'redux'
import rootReducer from '../Reducers/rootReducer.js';

export default function configureStore(initialState) {
    const store = createStore(rootReducer, initialState);

    if(module.hot){
        module.hot.accept('../Reducers/rootReducer.js', () => {
            const nextRootReducer = require('../Reducers/rootReducer.js');
            store.replaceReducer(nextRootReducer);
        })
    }

    return store;
}