import { React, useState, useContext, useEffect } from "react";
import * as usersService from "../../services/usersService";
import UserContext from "../../contexts/UserContext";
import { Card, Col, Button, Alert, Form } from 'react-bootstrap';

const Login = ({ history }) => {
  const [Email, setEmail] = useState("");
  const [Password, setPassword] = useState("");
  const { userInfo } = useContext(UserContext);  
  const [user, setUser] = userInfo;
 
  const onSubmitLoginHandler = async (e) => {
    e.preventDefault();
    const userData = {};    
    userData.email = Email;
    userData.password = Password;    
    const token = await usersService.signIn(userData);       
    setUser(Email);
    history.push("/");
  };
  return (
    <Form onSubmit={onSubmitLoginHandler}>
      <h1>Login</h1>
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
          required
        />
      </Form.Group>
      <Button variant="primary" type="submit">
    Login
  </Button>
    </Form>
  );
};

export default Login;
