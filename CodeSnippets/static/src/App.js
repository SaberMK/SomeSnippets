import React from 'react';
import NavBarHeading from "./Components/Navigation/NavBarHeading.js";
import MainPage from "./Components/MainPage.js";
import LoginPage from "./Components/User/LoginPage.js";
import RegistrationPage from "./Components/User/RegistrationPage.js";
import AddSnippetPage from "./Components/Snippet/AddSnippetPage.js";

import { BrowserRouter, Route } from 'react-router-dom';
import { Container } from 'semantic-ui-react';


function App(props) {
  return (
    <BrowserRouter >
      <div className="App">
        <NavBarHeading />
          <Container style={{paddingTop: '30px'}}>
            <Route path="/" exact component={MainPage} />
            <Route path="/login" component={LoginPage} />
            <Route path="/registration" component={RegistrationPage} />
            <Route path="/addSnippet" component={AddSnippetPage} />
          </Container>
      </div>
    </BrowserRouter>
  );
}

export default App;
