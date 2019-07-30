import React from 'react';
import { Form, Button } from 'semantic-ui-react'
import { reduxForm, Field } from "redux-form";
import { formInput } from './Helpers';

const LoginForm = ({handleSubmit}) => (
    <Form onSubmit={handleSubmit}>
        <Form.Field>
            <label>Login</label>
            <Field name="login" placeholder="Your login" id='login' width='6' component={formInput} />
        </Form.Field>
        <Form.Field>
            <label>Password</label>
            <Field name="password" placeholder="Your password" id='login' width='6' component={formInput} />
        </Form.Field>
        <Button type='submit' >Submit</Button>
    </Form>
)

const onSubmit = values => {
    console.log('Values', values);
}

export default reduxForm({
    form: 'loginForm',
    onSubmit
})(LoginForm);