import { createAction } from '@ngrx/store';

// This is the action actually dispatched by the component.
export const increment = createAction('[Counter] Increment');
export const decrement = createAction('[Counter] Decrement');
export const reset = createAction('[Counter] Reset');
