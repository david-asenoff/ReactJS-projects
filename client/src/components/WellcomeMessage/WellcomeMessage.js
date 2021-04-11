import { useContext } from "react";
import UserContext from "../../contexts/UserContext";

const WellcomeMessage = (props) => {
  const { authInfo } = useContext(UserContext);
  const { isAuthenticated } = authInfo;
  const { userInfo } = useContext(UserContext);

  return <>Welcome, {isAuthenticated ? userInfo[0] : "Guest"} !</>;
};
export default WellcomeMessage;
