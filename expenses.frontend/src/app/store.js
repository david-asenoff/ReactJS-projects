import { configureStore } from '@reduxjs/toolkit';
import expensesSlice from './expensesSlice';

export const store = configureStore({
  reducer: {
    expensesSlice: expensesSlice
  },
});
