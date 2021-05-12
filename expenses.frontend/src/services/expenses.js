import { ActionCreators } from '../app/expensesReducer';
import * as axios from 'axios';

const axiosInstance = axios.create({
    baseURL: 'https://localhost:44377/Expenses',
})

export const GetExpenses = async (dispatch) => {
    try {
        // api call
        const {data} = await axiosInstance.get();

        dispatch(ActionCreators.setExpenses(data));
    } catch {
        console.log('Error!');
    }
}

export const NewExpense = async (dispatch, expense) => {
    try {
        // api call
        dispatch(ActionCreators.newExpense({id: 10, description: expense.description,
        amount: expense.amount}));
    } catch {
        console.log('Error!');
    }
}

export const EditExpense = async (dispatch, expense) => {
    try {
        // api call
        dispatch(ActionCreators.editExpense(expense));
    } catch {
        console.log('Error!');
    }
}

export const DeleteExpense = async (dispatch, expense) => {
    try {
        // api call
        dispatch(ActionCreators.deleteExpense(expense));
    } catch {
        console.log('Error!');
    }
}