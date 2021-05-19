import { newExpense, editExpense, deleteExpense } from '../app/expensesSlice';
import {toast} from 'react-toastify';

const ToastMiddleware = () => next => action => {
    switch(action.type){
        case newExpense.type:
            toast.success('New expense added successfully');
            break;
            case editExpense.type:
            toast.success('Expense is edited successfully');
            break;
            case deleteExpense.type:
            toast.success('Expense  is deleted successfully');
            break;
            default:
                break;
    }
    return next(action);
}

export default ToastMiddleware;