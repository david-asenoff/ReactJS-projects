import ExpenseList from "./ExpenseList";
import ExpenseForm from "./ExpenseForm";
import { ToastContainer } from "react-toastify";

const HomePage = () => (
    <div style={{ width: '60%', margin: 'auto' }}>
        <ToastContainer />
        <h3>New expense</h3>
        <ExpenseForm />
        <hr style={{ border: '1px solid gray' }} />
        <h3>Your expenses</h3>
        <ExpenseList />
    </div>
);
export default HomePage;