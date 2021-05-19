import ExpenseList from "./components/ExpenseList";
import ExpenseForm from "./components/ExpenseForm";
import { ToastContainer } from "react-toastify";

const App = () => (
  <div style={{ width: '60%', margin: 'auto' }}>
    <ToastContainer/>
    <h3>New expense</h3>
    <ExpenseForm/>
    <hr style={{border:'1px solid gray'}}/>
    <h3>Your expenses</h3>
    <ExpenseList />
  </div>
);

export default App;
