import { createReducer, on } from '@ngrx/store';
import { increment, decrement, reset } from './counter.actions';

export interface CounterState {
  count: number;
}

export const initialState: CounterState = { count: 0 };

// BUG (find via Redux DevTools + a reducer breakpoint):
// The `on(increment, ...)` handler below has been swapped for a
// mistyped action reference so it silently never matches the real
// dispatched action. Open Redux DevTools, dispatch "Increment via Store",
// see the action fire but the state stay at 0. Then set a breakpoint
// inside this reducer and step through to find the mismatch.
export const counterReducer = createReducer(
  initialState,
  on(increment, (state) => {
    // Intentionally-wrong logic to simulate the mismatch bug:
    // pretend this only fires on decrement (comment-only bug marker,
    // real bug is the swapped condition below).
    return state; // <-- BUG: should be { count: state.count + 1 }
  }),
  on(decrement, (state) => ({ count: state.count - 1 })),
  on(reset, () => initialState)
);
