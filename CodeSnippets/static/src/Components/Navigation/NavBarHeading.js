import React from 'react';
import {
    Container,
    Menu,
    Segment,
  } from 'semantic-ui-react'
import { withRouter } from 'react-router-dom';
import Favicon from './favicon.bmp';

import NavBarUserPanel from "./NavBarUserPanel.js";

const NavBarHeading = (props) => {
    return ( 
          <Segment
            textAlign='center'
            vertical
          >
            <Menu
              fixed='top'
              inverted={false}
              size='large'
            >
              <Container>
                <img src={Favicon} alt="logo" style={{ marginTop: '0.4em', marginLeft: '0.1em',width: '30px', height: '30px' }}/>
                <Menu.Item as='a' onClick={()=>{props.history.push('/')}}>Some snippets</Menu.Item>
                <NavBarUserPanel isAuth='false' />
              </Container>
            </Menu>
          </Segment>);
}
 
export default withRouter(NavBarHeading);