
public static Version ParseVersion(String sVersion) {
  if (string.IsNullOrEmpty(sVersion.trim())) {
    throw new ArgumentNullException("sVersion");
  }

  Regex reg = new Regex(@"^(\d+)\.(\d+)\.(\d+).*?\.?(?(?<=\.)(\d+)|)");
  var matches = reg.Match(sVersion);
  var strs = matches.Groups.Cast<Group>().Skip(1).Where(group => !string.IsNullOrEmpty(group.Value)).Select(group => group.Value);
  var val = string.Join(".", strs);
  return System.Version.Parse(val);
}
