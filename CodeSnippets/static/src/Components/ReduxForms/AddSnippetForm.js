import React from 'react';
import { Form, Button, FormTextArea } from 'semantic-ui-react'
import { reduxForm, Field, formValueSelector  } from 'redux-form'
import { FormInput, FormTextareaInput } from './Helpers';
import axios from 'axios';
import { connect } from 'react-redux';

const values123 = [
    {key: 'C#', text: 'C#', value: 'C#'},
    {key: 'JS', text: 'JS', value: 'JS'}
];

const AddSnippetForm = props => {
    let { values } = props;
    return ( <Form onSubmit={()=> handleAddSnippet(values)}>
        <Form.Group inline>
            <Form.Field>
                <label>Name</label>
                <Field name="name" placeholder="Snippet Name" id="name" component={FormInput} />
            </Form.Field>
        </Form.Group>
        <Form.Field>
            <label>Description</label>
            <Field name="description" placeholder="Snippet Description" id="description" width={8} component={FormInput} />
        </Form.Field>
        <Form.Field>
            <label>Code</label>
            <Field name="code" placeholder="Past your code here" id="code" width={8} height={20} component={FormTextareaInput} />
        </Form.Field>
        <Button type='submit' >Add snippet</Button>
    </Form> );
}

const handleAddSnippet = ( values ) => {
    console.log(values);
}

const selector = formValueSelector('addSnippetForm');

const mapStateToProps = state => ({
    values : selector(state, 'name', 'description', 'code')
})

export default reduxForm({
    form : 'addSnippetForm',
    onSubmit : handleAddSnippet
})(connect(mapStateToProps)(AddSnippetForm));