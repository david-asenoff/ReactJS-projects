/* eslint-disable import/no-anonymous-default-export */
import { Form, Row, Col, Button } from "react-bootstrap"
import { React, useState, useEffect } from 'react';
import { DeleteExpense, NewExpense, EditExpense } from "../services/expenses";
import { useDispatch } from 'react-redux';

export default ({ expense, setIsEditing }) => {
    const descriptions = ['Groceries', 'Credit Card', 'Student Loans', 'Eating out', 'Gas'];
    const [amount, setAmount] = useState(0);
    const [description, setDescription] = useState(descriptions[0]);
    const [isNewExpense, setIsNewExpense] = useState(true);
    const dispatch = useDispatch();

    useEffect(() => {
        if (expense !== undefined) {
            setIsNewExpense(false);
            setAmount(expense.amount);
        } else {
            setIsNewExpense(true)
        }
    }, [expense]);

    return <Form
        onSubmit={event => {
            event.preventDefault();
            if (isNewExpense) {
                // create a new expense
                NewExpense(dispatch, { description: description, amount: Number(amount) });
            }
            else {
                //edit expense
                EditExpense(dispatch, {id: expense.id, description: description, amount: Number(amount)});
                setIsEditing(false);
            }
        }}
    >
        <Row>
            <Col>
                <Form.Label>Description</Form.Label>
                <Form.Control as='select' onChange={event => setDescription(event.target.value)}>
                    {descriptions.map(x => <option>{x}</option>)}
                </Form.Control>
            </Col>
            <Col>
                <Form.Label>Amount</Form.Label>
                <Form.Control type='number' step='0.01' placeholder={amount}
                    onChange={event => setAmount(event.target.value)} />
            </Col>
            <div style={{ marginTop: 'auto' }}>
                {isNewExpense ?
                    <Button variant='primary' type='submit'>Add</Button> :
                    <div>
                        <Button variant='danger' onClick={() => DeleteExpense(dispatch, expense)}>Delete</Button>
                        <Button variant='success' type='submit'>Save</Button>
                        <Button variant='default' onClick={() => setIsEditing(false)}>Cancel</Button>
                    </div>
                }
            </div>
        </Row>
    </Form>
}