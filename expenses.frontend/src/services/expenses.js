import { setExpenses, newExpense, editExpense, deleteExpense } from '../app/expensesSlice';
import * as axios from 'axios';

const axiosInstance = axios.create({
    baseURL: 'https://localhost:44377/Expenses',
})

export const GetExpenses = async (dispatch) => {
    try {
        // api call
        const { data } = await axiosInstance.get();

        dispatch(setExpenses(data));
    } catch {
        console.log('Error!');
    }
}

export const NewExpense = async (dispatch, expense) => {
    try {
        // api call
        const { data } = await axiosInstance.post('', expense);
        dispatch(newExpense(data));
    } catch {
        console.log('Error!');
    }
}

export const EditExpense = async (dispatch, expense) => {
    try {
        // api call
        await axiosInstance.put('', expense);
        dispatch(editExpense(expense));
    } catch {
        console.log('Error!');
    }
}

export const DeleteExpense = async (dispatch, expense) => {
    try {
        // api call
        await axiosInstance.delete('', { data: { ...expense } });
        dispatch(deleteExpense(expense));
    } catch {
        console.log('Error!');
    }
}