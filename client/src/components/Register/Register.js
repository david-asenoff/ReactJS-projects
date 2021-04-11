import {useState, useContext } from "react";
import * as usersService from "./../../services/usersService";
import { Card, Col, Button, Alert, Form } from 'react-bootstrap';

const Register = ({ history }) => {
  const [email, setEmail] = useState("");
  const [Password, setPassword] = useState("");
  const onSubmitHandler = (e) => {
    e.preventDefault();
    const userData = {};
    userData.Email = email;
    userData.Password = Password;
    usersService.Register(userData);
    history.push("/");
  };
  return (
    <Form onSubmit={onSubmitHandler}>
      <h1>Register</h1>
      <Form.Group controlId="exampleForm.ControlInput1">
    <Form.Label>Email address</Form.Label>
        <Form.Control
          type="email"
          name="Email"
          onChange={(e) => setEmail(e.target.value)}
          required
        />
       </Form.Group>
       <Form.Group  controlId="formPlaintextPassword">
    <Form.Label column sm="2">
      Password
    </Form.Label>
        <Form.Control
          type="password"
          name="Password"
          onChange={(e) => setPassword(e.target.value)}
        />
      </Form.Group>
      <Form.Group  controlId="formPlaintextPassword">
    <Form.Label column sm="2">
      Confirm password
    </Form.Label>
        <Form.Control type="pasword" name="Confirm Password" />
        </Form.Group>
        <Button variant="primary" type="submit">
    Submit
  </Button>
    </Form>
  );
};

export default Register;
