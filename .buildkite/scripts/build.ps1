IF  ($env:BUILDKITE_OUTPUT -eq 0) {
	throw "Build Fail. Error occured";
}

Write-Output "--- Build Success";
