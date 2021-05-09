const initialState = {
    expenses: [],
}

export const ActionTypes = {
    SET_EXPENSES: 'SET_EXPENSES',
    NEW_EXPENSE: 'NEW_EXPENSE',
    EDIT_EXPENSE: 'EDIT_EXPENSE',
    DELETE_EXPENSE: 'DELETE_EXPENSE',
}

export const ActionCreators = {
    setExpenses: payload => ({ type: ActionTypes.SET_EXPENSES, payload }),
    newExpense: payload => ({ type: ActionTypes.NEW_EXPENSE, payload }),
    editExpense: payload => ({ type: ActionTypes.EDIT_EXPENSE, payload }),
    deleteExpense: payload => ({ type: ActionTypes.DELETE_EXPENSE, payload }),
}

export default (state = initialState, action) => {
    switch (action.type) {
        case ActionTypes.SET_EXPENSES:
            return { ...state, expenses: [...action.payload] };

        case ActionTypes.NEW_EXPENSE:
            return { ...state, expenses: [action.payload, ...state.expenses] };

            case ActionTypes.EDIT_EXPENSE:
                var expenses = state.expenses.map(x=>{
                    if(x.id===action.payload.id){
                        x=action.payload;
                    }
                    return x;
                });
            return { ...state, expenses: [...expenses] };

            case ActionTypes.DELETE_EXPENSE:
                var expenses = state.expenses.filter(x=>x.id!==action.payload.id);
            return { ...state, expenses: [...expenses] };

        default: return state;
    }
}