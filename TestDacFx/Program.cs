using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDacFx {
    class Program {
        static void Main(string[] args) {
            var factory = new Microsoft.SqlServer.Dac.CodeAnalysis.CodeAnalysisServiceFactory();
            var codeAnalysisService=factory.CreateAnalysisService(Microsoft.SqlServer.Dac.Model.SqlServerVersion.Sql150);
            //Microsoft.SqlServer.Dac.Model.TSqlModel model = new Microsoft.SqlServer.Dac.Model.TSqlModel(Microsoft.SqlServer.Dac.Model.SqlServerVersion.Sql150, Microsoft.SqlServer.Dac.DacSchemaModelStorageType.Memory);
            var csb = new SqlConnectionStringBuilder();
            csb.DataSource = ".";
            csb.InitialCatalog = "SqlAnalyseLibrary";
            csb.IntegratedSecurity = true;
            var options = new Microsoft.SqlServer.Dac.Model.ModelExtractOptions();
            options.ExtractApplicationScopedObjectsOnly = false;
            options.ExtractReferencedServerScopedElements = true;
            options.IgnoreExtendedProperties = true;
            options.IgnorePermissions = false;
            options.LoadAsScriptBackedModel = true;
            options.Storage = Microsoft.SqlServer.Dac.DacSchemaModelStorageType.Memory;
            var model = Microsoft.SqlServer.Dac.Model.TSqlModel.LoadFromDatabase(csb.ConnectionString, options);
            var tables = model.GetObjects(Microsoft.SqlServer.Dac.Model.DacQueryScopes.All, Microsoft.SqlServer.Dac.Model.Table.TypeClass).ToArray();
            var table = tables[0];
            var children = table.GetChildren().ToArray();
            var results = codeAnalysisService.Analyze(model);
        }
    }
}
