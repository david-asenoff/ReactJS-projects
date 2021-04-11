import { React, useState, useContext } from "react";
import * as usersService from "../../services/usersService";
import UserContext from "../../contexts/UserContext";
import { Button, Form } from 'react-bootstrap';
import { NotificationManager} from 'react-notifications';

const Login = ({ history }) => {
  const [Email, setEmail] = useState("");
  const [Password, setPassword] = useState("");
  const { userInfo } = useContext(UserContext);  
  const [user, setUser] = userInfo;
  let message = "";
 

  const createNotification = (type) => {
    // eslint-disable-next-line default-case
    switch (type) {
      case "info":
        NotificationManager.info("Info message");
        break;
      case "success":
        NotificationManager.success("Successful Login");
        break;
      case "warning":
        NotificationManager.warning(
          "Warning message",
          "Close after 3000ms",
          3000
        );
        break;
      case "error":
        NotificationManager.error("Wrong login credentials", "", 5000, () => {
          alert("callback");
        });
        break;
    }
  };

  const onSubmitLoginHandler = async (e) => {
    e.preventDefault();
    const userData = {};    
    userData.email = Email;
    userData.password = Password;    
    const token = await usersService.signIn(userData).then(x=>{
      message="success";
      setUser(Email);
    history.push("/");})
    .catch(x=>{
      message="error";
    history.push("/Login")});

      createNotification(message);
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
