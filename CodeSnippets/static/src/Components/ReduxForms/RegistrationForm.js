import React from 'react';
import { Form, Button } from 'semantic-ui-react'
import { reduxForm, Field } from "redux-form";
import { formInput } from './Helpers';

const RegistrationForm = ({handleSubmit}) => (
    <Form onSubmit={handleSubmit}>
        <Form.Field>
            <label>Login</label>
            <Field name="username" placeholder="Your login" id='username' width='6' component={formInput} />
        </Form.Field>
        <Form.Field>
            <label>Password</label>
            <Field name="password" placeholder="Your password" id='password' width='6' component={formInput} />
        </Form.Field>
        <Form.Field>
            <label>Password Confirmation</label>
            <Field name="passwordConfirmation" placeholder="Your password confirmation" id='passwordConfirmation' width='6' component={formInput} />
        </Form.Field>
        <Button type='submit' >Submit</Button>
    </Form>
)

const onSubmit = values => {
    console.log('Values', values);
}

export default reduxForm({
    form: 'registrationForm',
    onSubmit
})(RegistrationForm);