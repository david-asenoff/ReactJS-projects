import { ActionCreators } from '../app/expensesReducer';

export const GetExpenses = async (dispatch) => {
    try {
        // api call
        const expenses = [
            { id: 1, description: 'Groceries', amount: 23.16},
            { id: 2, description: 'Gas', amount: 18.52},
            { id: 3, description: 'Student Loans', amount: 600},
        ];

        dispatch(ActionCreators.setExpenses(expenses));
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