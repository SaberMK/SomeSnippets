import React from 'react';
import { Form, Button } from 'semantic-ui-react'
import { connect } from 'react-redux';

const LoginPage = (props) => {
    let { login, password } = props;
    return ( <div>
        <h2 position="center">Login Page</h2>
        <Form>
            <Form.Field>
                <label>Login</label>
                <Form.Input placeholder={'Your login'} value={login} width={6}/>
            </Form.Field>
            <Form.Field>
                <label>Password</label>
                <Form.Input placeholder={'Your password'} value={password} width={6}/>
            </Form.Field>
            <Button type='submit' >Submit</Button>
        </Form>
        </div> );
}

const mapStateToProps = ( {user} ) => {
    return {
        login : user.auth.login,
        password : user.auth.password,
    }
}

export default connect(mapStateToProps)(LoginPage);