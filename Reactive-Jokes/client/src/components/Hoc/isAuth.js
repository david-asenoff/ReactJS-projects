import { useContext } from "react";
import { useHistory } from "react-router-dom";
import UserContext from "../../contexts/UserContext";

const isAuth = (WrappedComponent) => {
  const Component = (props) => {
    const { authInfo } = useContext(UserContext);
    const {isAuthenticated} = authInfo;
    const history = useHistory();
    if (!isAuthenticated) {
      history.push("/login");

      return null;
    }

    return <WrappedComponent {...props} />;
  };

  return Component;
};

export default isAuth;
