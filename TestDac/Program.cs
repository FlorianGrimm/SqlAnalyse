using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestDac {
    class Program {
        static void Main(string[] args) {
            var factory = new Microsoft.SqlServer.Dac.CodeAnalysis.CodeAnalysisServiceFactory();
            var codeAnalysisService = factory.CreateAnalysisService(Microsoft.SqlServer.Dac.Model.SqlServerVersion.Sql150);
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
            foreach (var obj in tables) {
                System.Console.Out.WriteLine($"Table {obj.Name.ToString()}");
                var children = obj.GetChildren().ToArray();
                foreach (var child in children) {
                    if (child.Name.HasName) {
                        System.Console.Out.WriteLine($"  child: {child.ObjectType.Name} - {child.Name.ToString()}");
                    }
                }
                foreach (var referenced in obj.GetReferenced().ToArray()) {
                    System.Console.Out.WriteLine($"  referenced: {referenced.ObjectType.Name} - {referenced.Name.ToString()}");
                }

                foreach (var referencing in obj.GetReferencing().ToArray()) {
                    System.Console.Out.WriteLine($"  referencing: {referencing.ObjectType.Name} - {referencing.Name.ToString()}");
                }
            }
            var procedures = model.GetObjects(Microsoft.SqlServer.Dac.Model.DacQueryScopes.All, Microsoft.SqlServer.Dac.Model.Procedure.TypeClass).ToArray();
            foreach (var obj in procedures) {
                System.Console.Out.WriteLine($"Procedure {obj.Name.ToString()}");
                var children = obj.GetChildren().ToArray();
                foreach (var child in children) {
                    if (child.Name.HasName) {
                        System.Console.Out.WriteLine($"  child: {child.ObjectType.Name} - {child.Name.ToString()}");
                    }
                }
                foreach (var referenced in obj.GetReferenced().ToArray()) {
                    System.Console.Out.WriteLine($"  referenced: {referenced.ObjectType.Name} - {referenced.Name.ToString()}");
                }

                foreach (var referencing in obj.GetReferencing().ToArray()) {
                    System.Console.Out.WriteLine($"  referencing: {referencing.ObjectType.Name} - {referencing.Name.ToString()}");
                }
            }
            var results = codeAnalysisService.Analyze(model);
        }
    }
}
