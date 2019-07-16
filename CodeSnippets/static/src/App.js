import React from 'react';
import NavBarHeading from "./Components/Navigation/NavBarHeading.js";
import MainPage from "./Components/MainPage.js";
import LoginPage from "./Components/User/LoginPage.js";
import RegistrationPage from "./Components/User/RegistrationPage.js";

import { BrowserRouter, Route } from 'react-router-dom';


function App(props) {
  return (
    <BrowserRouter >
      <div className="App">
        <NavBarHeading />
        <div style={{paddingTop: '30px'}}>
          <Route path="/" exact component={MainPage} />
          <Route path="/login" component={LoginPage} />
          <Route path="/registration" component={RegistrationPage} />
        </div>
      </div>
    </BrowserRouter>
  );
}

export default App;
