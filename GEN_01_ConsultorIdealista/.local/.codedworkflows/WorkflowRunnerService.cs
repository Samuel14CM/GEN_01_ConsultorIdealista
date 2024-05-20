using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace GEN_01_ConsultorIdealista
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Modulos/Leer_Correos.xaml
        /// </summary>
        public System.Collections.Generic.List<System.Net.Mail.MailMessage> Leer_Correos(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _runWorkflowHandler(@"Modulos\Leer_Correos.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default);
            return (System.Collections.Generic.List<System.Net.Mail.MailMessage>)result["out_listaMails"];
        }

        /// <summary>
        /// Invokes the Tests/InitAllSettingsTestCase.xaml
        /// </summary>
        public void InitAllSettingsTestCase()
        {
            var result = _runWorkflowHandler(@"Tests\InitAllSettingsTestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(string in_OrchestratorQueueName, string in_OrchestratorQueueFolder)
        {
            var result = _runWorkflowHandler(@"Main.xaml", new Dictionary<string, object>{{"in_OrchestratorQueueName", in_OrchestratorQueueName}, {"in_OrchestratorQueueFolder", in_OrchestratorQueueFolder}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Modulos/AccesoChatGPT/TestCaseAccesoChatGPT.xaml
        /// </summary>
        public void TestCaseAccesoChatGPT()
        {
            var result = _runWorkflowHandler(@"Modulos\AccesoChatGPT\TestCaseAccesoChatGPT.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/InitAllSettings.xaml
        /// </summary>
        public System.Collections.Generic.Dictionary<string, object> InitAllSettings(string in_ConfigFile, string[] in_ConfigSheets)
        {
            var result = _runWorkflowHandler(@"Framework\InitAllSettings.xaml", new Dictionary<string, object>{{"in_ConfigFile", in_ConfigFile}, {"in_ConfigSheets", in_ConfigSheets}}, default, default, default);
            return (System.Collections.Generic.Dictionary<string, object>)result["out_Config"];
        }

        /// <summary>
        /// Invokes the Tests/MainTestCase.xaml
        /// </summary>
        public void MainTestCase()
        {
            var result = _runWorkflowHandler(@"Tests\MainTestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Modulos/Subir a orquestador/Subir a Orquestador.xaml
        /// </summary>
        public void Subir_a_Orquestador()
        {
            var result = _runWorkflowHandler(@"Modulos\Subir a orquestador\Subir a Orquestador.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Modulos/AccesoChatGPT/AccesoChatGPT.xaml
        /// </summary>
        public void AccesoChatGPT(System.Collections.Generic.Dictionary<string, object> In_Config)
        {
            var result = _runWorkflowHandler(@"Modulos\AccesoChatGPT\AccesoChatGPT.xaml", new Dictionary<string, object>{{"In_Config", In_Config}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Modulos/TestCase_Envio_Correos.xaml
        /// </summary>
        public void TestCase_Envio_Correos()
        {
            var result = _runWorkflowHandler(@"Modulos\TestCase_Envio_Correos.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/GetTransactionData.xaml
        /// </summary>
        public (UiPath.Core.QueueItem out_TransactionItem, string out_TransactionField1, string out_TransactionField2, string out_TransactionID, System.Data.DataTable io_dt_TransactionData) GetTransactionData(int in_TransactionNumber, System.Collections.Generic.Dictionary<string, object> in_Config, System.Data.DataTable io_dt_TransactionData)
        {
            var result = _runWorkflowHandler(@"Framework\GetTransactionData.xaml", new Dictionary<string, object>{{"in_TransactionNumber", in_TransactionNumber}, {"in_Config", in_Config}, {"io_dt_TransactionData", io_dt_TransactionData}}, default, default, default);
            return ((UiPath.Core.QueueItem)result["out_TransactionItem"], (string)result["out_TransactionField1"], (string)result["out_TransactionField2"], (string)result["out_TransactionID"], (System.Data.DataTable)result["io_dt_TransactionData"]);
        }

        /// <summary>
        /// Invokes the Modulos/Envio_Correos.xaml
        /// </summary>
        public void Envio_Correos(System.Collections.Generic.Dictionary<string, object> in_Config, string in_elementoCola, string in_resultadosBusqueda)
        {
            var result = _runWorkflowHandler(@"Modulos\Envio_Correos.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_elementoCola", in_elementoCola}, {"in_resultadosBusqueda", in_resultadosBusqueda}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/InitAllApplications.xaml
        /// </summary>
        public void InitAllApplications(System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _runWorkflowHandler(@"Framework\InitAllApplications.xaml", new Dictionary<string, object>{{"in_Config", in_Config}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Tests/ProcessTestCase.xaml
        /// </summary>
        public void ProcessTestCase()
        {
            var result = _runWorkflowHandler(@"Tests\ProcessTestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/SetTransactionStatus.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions) SetTransactionStatus(UiPath.Core.BusinessRuleException in_BusinessException, string in_TransactionField1, string in_TransactionField2, string in_TransactionID, System.Exception in_SystemException, System.Collections.Generic.Dictionary<string, object> in_Config, UiPath.Core.QueueItem in_TransactionItem, int io_RetryNumber, int io_TransactionNumber, int io_ConsecutiveSystemExceptions)
        {
            var result = _runWorkflowHandler(@"Framework\SetTransactionStatus.xaml", new Dictionary<string, object>{{"in_BusinessException", in_BusinessException}, {"in_TransactionField1", in_TransactionField1}, {"in_TransactionField2", in_TransactionField2}, {"in_TransactionID", in_TransactionID}, {"in_SystemException", in_SystemException}, {"in_Config", in_Config}, {"in_TransactionItem", in_TransactionItem}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}, {"io_ConsecutiveSystemExceptions", io_ConsecutiveSystemExceptions}}, default, default, default);
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"], (int)result["io_ConsecutiveSystemExceptions"]);
        }

        /// <summary>
        /// Invokes the Framework/CloseAllApplications.xaml
        /// </summary>
        public void CloseAllApplications()
        {
            var result = _runWorkflowHandler(@"Framework\CloseAllApplications.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Tests/WorkflowTestCaseTemplate.xaml
        /// </summary>
        public void WorkflowTestCaseTemplate()
        {
            var result = _runWorkflowHandler(@"Tests\WorkflowTestCaseTemplate.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Tests/GetTransactionDataTestCase.xaml
        /// </summary>
        public void GetTransactionDataTestCase()
        {
            var result = _runWorkflowHandler(@"Tests\GetTransactionDataTestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Modulos/Busqueda de Resultados/Busqueda de resultados.xaml
        /// </summary>
        public void Busqueda_de_resultados()
        {
            var result = _runWorkflowHandler(@"Modulos\Busqueda de Resultados\Busqueda de resultados.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Modulos/AccesoIdealista/AccesoIdealista.xaml
        /// </summary>
        public void AccesoIdealista()
        {
            var result = _runWorkflowHandler(@"Modulos\AccesoIdealista\AccesoIdealista.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Modulos/TestCase_Leer_Correos.xaml
        /// </summary>
        public void TestCase_Leer_Correos()
        {
            var result = _runWorkflowHandler(@"Modulos\TestCase_Leer_Correos.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/RetryCurrentTransaction.xaml
        /// </summary>
        public (int io_RetryNumber, int io_TransactionNumber) RetryCurrentTransaction(System.Collections.Generic.Dictionary<string, object> in_Config, System.Exception in_SystemException, bool in_QueueRetry, int io_RetryNumber, int io_TransactionNumber)
        {
            var result = _runWorkflowHandler(@"Framework\RetryCurrentTransaction.xaml", new Dictionary<string, object>{{"in_Config", in_Config}, {"in_SystemException", in_SystemException}, {"in_QueueRetry", in_QueueRetry}, {"io_RetryNumber", io_RetryNumber}, {"io_TransactionNumber", io_TransactionNumber}}, default, default, default);
            return ((int)result["io_RetryNumber"], (int)result["io_TransactionNumber"]);
        }

        /// <summary>
        /// Invokes the Framework/KillAllProcesses.xaml
        /// </summary>
        public void KillAllProcesses()
        {
            var result = _runWorkflowHandler(@"Framework\KillAllProcesses.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Tests/InitAllApplicationsTestCase.xaml
        /// </summary>
        public void InitAllApplicationsTestCase()
        {
            var result = _runWorkflowHandler(@"Tests\InitAllApplicationsTestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Framework/TakeScreenshot.xaml
        /// </summary>
        public string TakeScreenshot(string in_Folder, string io_FilePath)
        {
            var result = _runWorkflowHandler(@"Framework\TakeScreenshot.xaml", new Dictionary<string, object>{{"in_Folder", in_Folder}, {"io_FilePath", io_FilePath}}, default, default, default);
            return (string)result["io_FilePath"];
        }

        /// <summary>
        /// Invokes the Framework/Process.xaml
        /// </summary>
        public void Process(UiPath.Core.QueueItem in_TransactionItem, System.Collections.Generic.Dictionary<string, object> in_Config)
        {
            var result = _runWorkflowHandler(@"Framework\Process.xaml", new Dictionary<string, object>{{"in_TransactionItem", in_TransactionItem}, {"in_Config", in_Config}}, default, default, default);
        }
    }
}