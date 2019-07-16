import React, {Component} from 'react';
import { Button, Menu } from "semantic-ui-react";
import { withRouter } from 'react-router-dom';

class NavBarUserPanel extends Component {
    render() { 
        let isAuth = this.props.isAuth;
        return ( 
            isAuth==='true' ? (<Menu.Item position='right'>
        <Button as='a' inverted={true} onClick={()=>this.props.history.push('/login')}>
          Log In
        </Button>
        <Button as='a' inverted={true} onClick={()=>this.props.history.push('/registration')} style={{ marginLeft: '0.5em' }}>
          Sign Up
        </Button>
            </Menu.Item>) : (
      <Menu.Item position='right'>Здарова, %USERNAME%</Menu.Item>));
    }
}
 //<Link as='p' to='/login'>Log In</Link>
export default withRouter(NavBarUserPanel);