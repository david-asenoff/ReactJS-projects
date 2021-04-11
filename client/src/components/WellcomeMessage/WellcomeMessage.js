import { useContext } from "react";
import UserContext from "../../contexts/UserContext";

const WellcomeMessage = (props) => {
  const { authInfo } = useContext(UserContext);
  const { isAuthenticated } = authInfo;
  const { userInfo } = useContext(UserContext);

  return <>Добре дошли, {isAuthenticated ? userInfo[0] : "Гост"} !</>;
};
export default WellcomeMessage;
