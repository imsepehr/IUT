from mininet.net import Mininet
from mininet.node import Controller, RemoteController, OVSKernelSwitch, UserSwitch
from mininet.cli import CLI
from mininet.log import setLogLevel, info 
from mininet.link import TCLink

def customTopo():
    net = Mininet(controller=RemoteController, link=TCLink, switch=OVSKernelSwitch)

    info('*** Adding controller\n')
    net.addController('c0', controller=RemoteController, ip='127.0.0.1', port=6633)

    info('*** Adding switches\n')
    s1 = net.addSwitch('s1')
    s2 = net.addSwitch('s2')
    s3 = net.addSwitch('s3')
    s4 = net.addSwitch('s4')
    s5 = net.addSwitch('s5')
    s6 = net.addSwitch('s6')
    s7 = net.addSwitch('s7')
    s8 = net.addSwitch('s8')


    info('*** Adding hosts\n')
    h1 = net.addHost('h1')
    h2 = net.addHost('h2')
    h3 = net.addHost('h3')
    h4 = net.addHost('h4')
    h5 = net.addHost('h5')
    h6 = net.addHost('h6')
    h7 = net.addHost('h7')
    h8 = net.addHost('h8')
    h9 = net.addHost('h9')
    h10 = net.addHost('h10')
    h11 = net.addHost('h11')
    h12 = net.addHost('h12')


    info('*** Creating links\n')
    net.addLink(s1, s2)
    net.addLink(s2, s3)
    net.addLink(s2, s5)
    net.addLink(s4, s5)
    net.addLink(s5, s6)
    net.addLink(s6, s7)
    net.addLink(s7, s8)
    net.addLink(s1, h1)
    net.addLink(s2, h2)
    net.addLink(s2, h3)
    net.addLink(s3, h4)
    net.addLink(s4, h5)
    net.addLink(s5, h6)
    net.addLink(s5, h7)
    net.addLink(s5, h8)
    net.addLink(s6, h9)
    net.addLink(s7, h10)
    net.addLink(s7, h11)
    net.addLink(s8, h12)

    info('*** Starting network\n')
    net.start()

    info('*** Running CLI\n')
    CLI(net)

    info('*** Stopping network\n')
    net.stop()

if __name__ == '__main__':
    setLogLevel('info')
    customTopo()
