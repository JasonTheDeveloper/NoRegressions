class NoregCli < Formula
    desc "Deploy machine learning with confidence."
    homepage "https://github.com/JasonTheDeveloper/NoRegressions"
    url "https://github.com/JasonTheDeveloper/NoRegressions/releases/download/v0.0.4-mac/noreg-osx-x64.tar.gz"
    sha256 "64e3a782c3bee5c94b9191ce4f289c66d1453bca401b951db3fb6a85a57c2db8"
  
    def install
        mv "./noreg-cli", "./noreg"
        bin.install Dir["./*"]
    end
    
    def post_install
        system "chmod -R 666 #{bin}/configsettings.json"
    end
  
    test do
        system "false"
    end
end

__END__
