using System;
using System.Diagnostics.CodeAnalysis;
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
        /// <summary>
        /// XML namespace for DMN 1.1 documents
        /// </summary>
        public const string XmlNamespaceDmn11 = "http://www.omg.org/spec/DMN/20151101/dmn.xsd";
        /// <summary>
        /// XML namespace for DMN 1.3 documents
        /// </summary>
        public const string XmlNamespaceDmn13 = "https://www.omg.org/spec/DMN/20191111/MODEL/";

        /// <summary>
        /// DMN standard version to be used by <see cref="DmnParser"/>
        /// </summary>
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        public enum DmnVersionEnum
        {
            /// <summary>
            /// DMN version 1.1
            /// </summary>
            V1_1,
            /// <summary>
            /// DMN version 1.3
            /// </summary>
            V1_3,
            /// <summary>
            /// DMN version 1.3 with extensions
            /// </summary>
            V1_3ext
        }

        internal static ILogger Logger = CommonLogging.CreateLogger<DmnParser>();

        /// <summary>
        /// DMN Model XML serializer for DMN v1.1
        /// </summary>
        protected static XmlSerializer DmnDefinitionsSerializer = new XmlSerializer(
            typeof(DmnModel), null, new Type[] { },
            defaultNamespace: XmlNamespaceDmn11, root: new XmlRootAttribute("definitions") { Namespace = XmlNamespaceDmn11 }
            );

        /// <summary>
        /// DMN Model XML serializer for DMN v1.3
        /// </summary>
        protected static XmlSerializer DmnDefinitionsSerializer13 = new XmlSerializer(
            typeof(DmnModel), null, new Type[] { },
            defaultNamespace: XmlNamespaceDmn13, root: new XmlRootAttribute("definitions") { Namespace = XmlNamespaceDmn13 }
            );

        /// <summary>
        /// Parse the <paramref name="filePath">file</paramref> with DMN Model XML definition based on <see cref="DmnVersionEnum.V1_3">DMN standard version 1.3</see>.
        /// </summary>
        /// <param name="filePath">Path to the file to be parsed</param>
        /// <returns> Parsed DMN Model</returns>
        /// <exception cref="DmnParserException">Missing file path (<paramref name="filePath"/> is null or empty)</exception>
        /// <exception cref="DmnParserException">File doesn't exist</exception>
        /// <exception cref="DmnParserException">Can't parse file</exception>
        public static DmnModel Parse13(string filePath)
        {
            return Parse(filePath, DmnVersionEnum.V1_3);
        }

        /// <summary>
        /// Parse the <paramref name="filePath">file</paramref> with DMN Model XML definition based on <see cref="DmnVersionEnum.V1_3">DMN standard version 1.3 with extensions</see>.
        /// </summary>
        /// <param name="filePath">Path to the file to be parsed</param>
        /// <returns> Parsed DMN Model</returns>
        /// <exception cref="DmnParserException">Missing file path (<paramref name="filePath"/> is null or empty)</exception>
        /// <exception cref="DmnParserException">File doesn't exist</exception>
        /// <exception cref="DmnParserException">Can't parse file</exception>
        // ReSharper disable once InconsistentNaming
        public static DmnModel Parse13ext(string filePath)
        {
            return Parse(filePath, DmnVersionEnum.V1_3ext);
        }

        /// <summary>
        /// Parse the <paramref name="filePath">file</paramref> with DMN Model XML definition based on <paramref name="dmnVersion">DMN standard version</paramref>.
        /// </summary>
        /// <param name="filePath">Path to the file to be parsed</param>
        /// <param name="dmnVersion">DMN standard version to be used for parsing. Version 1.1 (<see cref="DmnVersionEnum.V1_1"/> is used as default if the version is not provided.</param>
        /// <returns> Parsed DMN Model</returns>
        /// <exception cref="DmnParserException">Missing file path (<paramref name="filePath"/> is null or empty)</exception>
        /// <exception cref="DmnParserException">File doesn't exist</exception>
        /// <exception cref="DmnParserException">Can't parse file</exception>
        public static DmnModel Parse(string filePath, DmnVersionEnum dmnVersion = DmnVersionEnum.V1_1)
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

                    switch (dmnVersion)
                    {
                        case DmnVersionEnum.V1_1:
                            def = (DmnModel)DmnDefinitionsSerializer.Deserialize(rdr);
                            break;
                        case DmnVersionEnum.V1_3:
                        case DmnVersionEnum.V1_3ext:
                            def = (DmnModel)DmnDefinitionsSerializer13.Deserialize(rdr);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(dmnVersion), dmnVersion, null);
                    }

                    Logger.Info($"Parsed DMN file {filePath}");
                }
                catch (Exception ex)
                {
                    throw Logger.Fatal<DmnParserException>($"Can't parse file {filePath}: {ex.Message}", ex);
                }
            }

            def.DmnVersion=dmnVersion;
            return def;
        }

        /// <summary>
        /// Parse the <paramref name="dmnDefinition">string</paramref> with DMN Model XML definition based on <see cref="DmnVersionEnum.V1_3">DMN standard version 1.3</see>.
        /// </summary>
        /// <param name="dmnDefinition">DMN Model XML definition</param>
        /// <returns>Parsed DMN Model</returns>
        /// <exception cref="DmnParserException">Missing DMN Model definition (<paramref name="dmnDefinition"/> is null or empty)</exception>
        /// <exception cref="DmnParserException">Can't parse DMN definition</exception>
        public static DmnModel ParseString13(string dmnDefinition)
        {
            return ParseString(dmnDefinition, DmnVersionEnum.V1_3);
        }

        /// <summary>
        /// Parse the <paramref name="dmnDefinition">string</paramref> with DMN Model XML definition based on <see cref="DmnVersionEnum.V1_3">DMN standard version 1.3 with extensions</see>.
        /// </summary>
        /// <param name="dmnDefinition">DMN Model XML definition</param>
        /// <returns>Parsed DMN Model</returns>
        /// <exception cref="DmnParserException">Missing DMN Model definition (<paramref name="dmnDefinition"/> is null or empty)</exception>
        /// <exception cref="DmnParserException">Can't parse DMN definition</exception>
        // ReSharper disable once InconsistentNaming
        public static DmnModel ParseString13ext(string dmnDefinition)
        {
            return ParseString(dmnDefinition, DmnVersionEnum.V1_3ext);
        }

        /// <summary>
        /// Parse the <paramref name="dmnDefinition">string</paramref> with DMN Model XML definition based on <paramref name="dmnVersion">DMN standard version</paramref>.
        /// </summary>
        /// <param name="dmnDefinition">DMN Model XML definition</param>
        /// <param name="dmnVersion">DMN standard version to be used for parsing. Version 1.1 (<see cref="DmnVersionEnum.V1_1"/> is used as default if the version is not provided.</param>
        /// <returns>Parsed DMN Model</returns>
        /// <exception cref="DmnParserException">Missing DMN Model definition (<paramref name="dmnDefinition"/> is null or empty)</exception>
        /// <exception cref="DmnParserException">Can't parse DMN definition</exception>
        public static DmnModel ParseString(string dmnDefinition, DmnVersionEnum dmnVersion = DmnVersionEnum.V1_1)
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

                    switch (dmnVersion)
                    {
                        case DmnVersionEnum.V1_1:
                            def = (DmnModel)DmnDefinitionsSerializer.Deserialize(rdr);
                            break;
                        case DmnVersionEnum.V1_3:
                        case DmnVersionEnum.V1_3ext:
                            def = (DmnModel)DmnDefinitionsSerializer13.Deserialize(rdr);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(dmnVersion), dmnVersion, null);
                    }

                    Logger.Info($"Parsed DMN definition from given string");
                }
                catch (Exception ex)
                {
                    throw Logger.Fatal<DmnParserException>($"Can't parse definition from given string: {ex.Message}", ex);
                }
            }
            
            def.DmnVersion=dmnVersion;
            return def;
        }
    }
}
