import { configureStore, getDefaultMiddleware } from '@reduxjs/toolkit';
import expensesSlice from './expensesSlice';
import ToastMiddleware from '../middlewares/ToastMiddleware';
import { authenticationSlice } from './authenticationSlice';

export const store = configureStore({
  reducer: {
    authenticationSlice: authenticationSlice,
    expensesSlice: expensesSlice
  },
  middleware: (getDefaultMiddleware) => getDefaultMiddleware().concat(ToastMiddleware)
});
