using System;
using BeerApp.Core.Reducer;
using BeerApp.Core.States;
using Redux;

namespace BeerApp.Core
{
    public class StoreHolder
    {
        private StoreHolder()
        {

            var initialDataState = new DataState();

            DataStore = new Store<DataState>(reducer: MainReducer.Execute, initialState: initialDataState, middlewares: Taiste.Redux.Middleware.ThunkMiddleware);

        }

        public IStore<DataState> DataStore { get; set; }

        public static StoreHolder Instance { get; } = new StoreHolder();
    }
}
