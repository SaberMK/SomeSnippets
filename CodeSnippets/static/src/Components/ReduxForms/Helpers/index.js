import React from 'react';
import { Form, TextArea } from 'semantic-ui-react'

export const FormInput = props => <Form.Input
                type={ props.hasPassword === true ? "password" : 'input' } 
                {...props.input} 
                placeholder={props.placeholder} 
                width={props.width} 
            />;

export const FormTextareaInput = props => <Form.TextArea
               {...props.input}
               placeholder={props.placeholder}
               width={props.width}
               height={props.height}
            />;