using System;
using System.IO;
using System.Xml.Serialization;
using net.adamec.lib.common.core.logging;
using net.adamec.lib.common.dmn.engine.parser.dto;

namespace net.adamec.lib.common.dmn.engine.parser
{
    /// <summary>
    /// DMN Model XML parser
    /// </summary>
    public class DmnParser
    {
        protected static ILogger Logger = CommonLogging.CreateLogger<DmnParser>();

        /// <summary>
        /// DMN Model XML serializer
        /// </summary>
        protected static XmlSerializer DmnDefinitionsSerializer = new XmlSerializer(typeof(DmnModel));

        /// <summary>
        /// Parse the <paramref name="filePath">file</paramref> with DMN Model XML definition
        /// </summary>
        /// <param name="filePath">Path to the file to be parsed</param>
        /// <returns> Parsed DMN Model</returns>
        /// <exception cref="DmnParserException">Missing file path (<paramref name="filePath"/> is null or empty)</exception>
        /// <exception cref="DmnParserException">File doesn't exist</exception>
        /// <exception cref="DmnParserException">Can't parse file</exception>
        public static DmnModel Parse(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath)) throw Logger.Fatal<DmnParserException>($"{nameof(filePath)} is null or empty");
            if (!File.Exists(filePath)) throw Logger.Fatal<DmnParserException>($"File {filePath} doesn't exist");

            DmnModel def;
            // ReSharper disable once AssignNullToNotNullAttribute
            using (var rdr = new StreamReader(filePath))
            {
                try
                {
                    Logger.Info($"Parsing DMN file {filePath}...");
                    def = (DmnModel)DmnDefinitionsSerializer.Deserialize(rdr);
                    Logger.Info($"Parsed DMN file {filePath}");
                }
                catch (Exception ex)
                {
                    throw Logger.Fatal<DmnParserException>($"Can't parse file {filePath}: {ex.Message}", ex);
                }
            }

            return def;
        }

        /// <summary>
        /// Parse the <paramref name="dmnDefinition">string</paramref> with DMN Model XML definition
        /// </summary>
        /// <param name="dmnDefinition">DMN Model XML definition</param>
        /// <returns>Parsed DMN Model</returns>
        /// <exception cref="DmnParserException">Missing DMN Model definition (<paramref name="dmnDefinition"/> is null or empty)</exception>
        /// <exception cref="DmnParserException">Can't parse DMN definition</exception>
        public static DmnModel ParseString(string dmnDefinition)
        {
            dmnDefinition = dmnDefinition?.Trim();
            if (string.IsNullOrWhiteSpace(dmnDefinition)) throw Logger.Fatal<DmnParserException>("Missing DMN Model definition");

            DmnModel def;
            // ReSharper disable once AssignNullToNotNullAttribute
            using (var rdr = new StringReader(dmnDefinition))
            {
                try
                {
                    Logger.Info($"Parsing DMN definition from given string...");
                    if (Logger.IsTraceEnabled)
                        Logger.Trace(dmnDefinition);
                    def = (DmnModel)DmnDefinitionsSerializer.Deserialize(rdr);
                    Logger.Info($"Parsed DMN definition from given string");
                }
                catch (Exception ex)
                {
                    throw Logger.Fatal<DmnParserException>($"Can't parse definition from given string: {ex.Message}", ex);
                }
            }

            return def;
        }
    }
}
