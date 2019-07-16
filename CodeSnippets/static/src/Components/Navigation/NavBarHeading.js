import React from 'react';
import {
    Container,
    Menu,
    Segment,
    Visibility,
  } from 'semantic-ui-react'
import NavBarUserPanel from "./NavBarUserPanel.js";

const NavBarHeading = (props) => {
    return ( 
        <Visibility
          once={false}
        >
          <Segment
            inverted
            textAlign='center'
            vertical
          >
            <Menu
              fixed='top'
              inverted={true}
              pointing={false}
              secondary={false}
              size='large'
            >
              <Container>
                <Menu.Item as='a'>Home</Menu.Item>
                <Menu.Item as='a'>Work</Menu.Item>
                <Menu.Item as='a'>Company</Menu.Item>
                <Menu.Item as='a'>Careers</Menu.Item>
                <NavBarUserPanel isAuth='true' />
              </Container>
            </Menu>
          </Segment>
        </Visibility>);
}
 
export default NavBarHeading;