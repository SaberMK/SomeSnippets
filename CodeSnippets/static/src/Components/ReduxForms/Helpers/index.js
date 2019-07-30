import React from 'react';
import { Form } from 'semantic-ui-react'

export const formInput = props => <Form.Input {...props.input} placeholder={props.placeholder} width={props.width} />
