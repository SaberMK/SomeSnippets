import React, {Component} from 'react';
import { Button, Menu, Dropdown } from "semantic-ui-react";
import { withRouter } from 'react-router-dom';
import { connect } from 'react-redux';

class NavBarUserPanel extends Component {
    render() { 
        let isAuth = this.props.isAuth;
        let username = this.props.username;
        let greetingsText = `Здарова, ${username}!`;
        return ( 
            !isAuth ? (

              <Menu.Item position='right'>
                <Button as='a' inverted={true} onClick={()=>this.props.history.push('/login')}>
                  Log In
                </Button>
                <Button as='a' inverted={true} onClick={()=>this.props.history.push('/registration')} style={{ marginLeft: '0.5em' }}>
                  Sign Up
                </Button>
              </Menu.Item>) : (

              <Menu.Item position='right'>
                  <Dropdown text={greetingsText} >
                    <Dropdown.Menu>
                      <Dropdown.Item text='Profile' />
                      <Dropdown.Item text='Log out'/>
                    </Dropdown.Menu>
                  </Dropdown>
              </Menu.Item>));
    }
}

const mapStateToProps = ({global}) => {
  return {
    username : global.username
  }
};

export default withRouter(connect(mapStateToProps)(NavBarUserPanel));