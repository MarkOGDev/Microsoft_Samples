using System;
using MarkOGDev.Microsoft_Samples.WebHost_Sample.WebApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebHost_Sample.WebApplication.Pages
{ 

    public class IndexModel : PageModel
    { 
        /// <summary>
        /// Group the View Model Data together makes them easier to find via IntelliSense in Index.cshtml 
        /// </summary>
        public class IndexViewModel
        {
            public string Message { get; set; } = "Hello from the Page Model.";

            public IOperationService OperationService;

            public IOperationTransient TransientOperation;
            public IOperationScoped ScopedOperation;
            public IOperationSingleton SingletonOperation;
            public IOperationSingletonInstance SingletonInstanceOperation;
        }

        public readonly IndexViewModel ViewModel;

        /// <summary>
        /// Two way data binding for e.g.  HTML input
        /// </summary>
        [BindProperty]
        public int BindPropertyInt { get; set; } = 101;
               
        public IndexModel(
            IOperationService operationService,
            IOperationTransient transientOperation,
            IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation,
            IOperationSingletonInstance singletonInstanceOperation)
        {
            ViewModel = new IndexViewModel
            {
                OperationService = operationService,
                TransientOperation = transientOperation,
                ScopedOperation = scopedOperation,
                SingletonOperation = singletonOperation,
                SingletonInstanceOperation = singletonInstanceOperation
            };                 

        }

        public void OnGet()
        {
            ViewModel.Message += $" Server time is { DateTime.Now }";
        }
    }
}